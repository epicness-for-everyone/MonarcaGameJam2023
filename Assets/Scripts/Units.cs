using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    private Units TargetUnit;
    [SerializeField] private int life;
    [SerializeField] private int damage;
    [SerializeField][Range(0,3)] private float attackCooldown;
    [SerializeField] private float movementSpeed;
    [SerializeField][Range(-1,1)] private int direction;
    private bool move= false;
    private bool takingDamage;
    [SerializeField]private float recoilDistance;
    private float recoil;
    private float counAttackCooldown;
    private GameObject Target;
    [SerializeField] private string TagTarget;
    [SerializeField] private string TagTower;
    private Vector3 dmov;
    private void Awake(){}
    // Start is called before the first frame update
    void Start()
    {
        takingDamage= false;
        Target= null;
        ResetProperties();
    }

    // Update is called once per frame
    void Update()
    {
        if(move){
            if(takingDamage){
                dmov= new Vector3(direction * recoil * -1, 0, transform.position.z);
                recoil=(recoil >= 0)? recoil-0.2f : 0;
                counAttackCooldown+= Time.deltaTime;
                if(counAttackCooldown >= attackCooldown){
                    takingDamage= false;
                    resetTarget();
                }
            }else dmov= new Vector3(direction * movementSpeed, 0, transform.position.z);
            transform.Translate(dmov * Time.deltaTime);
        }
    }

    public void TakeDamage(int n){
        life-= n;
        if(life >= 0){
            //Sigo Vivo >:c
            takingDamage= true;
            ResetProperties();
        }else{
            // x.x
            resetTarget();
            gameObject.SetActive(false);
        }
    }
    //Colliders
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag(TagTarget) && Target==null){
            Target= col.gameObject;
            TargetUnit= Target.GetComponent<Units>();
            TargetUnit.TakeDamage(damage);
        }
        if(col.CompareTag(TagTower)){
            resetTarget();
            gameObject.SetActive(false);
        }
    }
    /*
    Borrar el comentario en caso de emergencias 
    (si no se quiere contar con la probabilidad de que las unidades se pasen de largo)
    private void OnTriggerExit2D(Collider2D col) {
        if(col.CompareTag(TagTarget)) Target=null;
    }
    */
    
    private void ResetProperties(){
        recoil= recoilDistance;
        counAttackCooldown= 0;
        //pruebas
        life=3;
    }
    public void resetTarget(){
        Target= null;
    }

    //getters and setters
    public void setMove(bool b){
        move= b;
    }
}
