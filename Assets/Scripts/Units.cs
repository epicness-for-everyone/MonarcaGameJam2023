using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour
{
    //[Header(Valores del tipo de unidad)]


    [Header("Valores propios de la unidad")]
    [SerializeField] private int life;
    [SerializeField] private int damage;
    [SerializeField][Range(0,3)] private float attackCooldown;
    [SerializeField] private float movementSpeed;
    [SerializeField][Range(-1,1)] private int direction;
    private Units TargetUnit;
    private bool move= false;
    private bool takingDamage;
    private Animator unitAnim;
    [SerializeField]
    [Tooltip("Es la distancia que hace recorrer a su objetivo")]private float recoilDistance;
    private float recoil;
    private float counAttackCooldown;
    private GameObject Target;
    private Vector3 dmov;
    private GameObject barLife;
    private life ctrBarLife;
    [Header("Etiquetas de los objetivos")]
    [SerializeField] private string TagTarget;
    [SerializeField] private string TagTower;
    
    private void Awake(){
        unitAnim= GetComponent<Animator>();
        barLife= transform.GetChild(0).gameObject;
        ctrBarLife= barLife.GetComponent<life>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(move){
            if(takingDamage){
                //Movimiento del retoceso que resulta al enfrentarse a otra unidad
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
        //Al recibir daño se verifica si la unidad sigue "viva"
        life-= n;
        ctrBarLife.TakingDamage(n);
        if(life >= 0){
            //Sigo Vivo >:c
            takingDamage= true;
            counAttackCooldown= 0;
            barLife.SetActive(true);
        }else{
            // x.x
            resetTarget();
            DieUnit();
        }
    }
    public void DieUnit(){
        //Cuando muere la unidad
        noMove();
        gameObject.SetActive(false);
    }
    public void ResetUnit(int nlife, int ndamage, int ndir, float speed, float nrecoilD, float anim){
        //Al momento de generar una nueva unidad se le asignan las nuevas propiedades y se reinicia sus variables
        life= nlife;
        damage= ndamage;
        direction= ndir;
        movementSpeed= speed;
        recoilDistance= nrecoilD;
        unitAnim.SetFloat("Type", anim);
        //Debug.Log("anim number "+anim);
        resetTarget();
        takingDamage= false;
        setMove();
        ctrBarLife.MaxLife(life);
        barLife.SetActive(false);
    }
    //Colliders
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.CompareTag(TagTarget) && Target==null && !takingDamage){
            Target= col.gameObject;
            TargetUnit= Target.GetComponent<Units>();
            TargetUnit.setRecoil(recoilDistance);
            TargetUnit.TakeDamage(damage);
        }
        if(col.CompareTag(TagTower)){
            resetTarget();
            gameObject.SetActive(false);
        }
    }
    
    //Borrar el comentario en caso de emergencias 
    //(si no se quiere contar con la probabilidad de que las unidades se pasen de largo)
    private void OnTriggerExit2D(Collider2D col) {
        if(col.CompareTag(TagTarget)) Target=null;
    }
    
    public void resetTarget(){
        Target= null;
    }

    //getters and setters
    public void setMove(){
        move= true;
        unitAnim.SetBool("walk",true);
    }
    public void noMove(){
        move= false;
        unitAnim.SetBool("walk",false);
    }
    public void setDamage(int n){
        damage= n;
    }
    public void setLife(int n){
        life= n;
    }
    public void setVelocity(float n){
        movementSpeed= n;
    }
    public void setDirection(int n){
        //Recibe la direeción a la cual se va a mover
        direction= n;
    }
    public void setRecoil(float d){
        //Recive la distancia que va a recorrer
        recoil= d;
    }
}
