using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables

    //variables 1 
    float speed; // Tốc độ di chuyển của kẻ địch
    //variables 2
    float damage; //Số lượng sát thương mà kẻ địch có thể gây ra
    //variables 3 
    bool isStunned; // Xác định xem kẻ địch có bị làm choáng hay không
    //variables 4 
    float attackRange; // Phạm vi tấn công
    //variables 5 
    int rewardPoints; // Điểm thưởng khi tiêu diệt kẻ địch

    // 5 Enemies methods

    //Method 1
    protected void Die() //Chết
    {

    }
    //Method 2
    protected void Spawn() // tạo ra 
    {
        
    }
    //Method 3
    protected void Move()  //di chuyển
    {
        
    }
    //Method 4
    protected void TakeDamage() // nhận sát thương
    {
        
    }
    //Method 5    
    protected void Defend()  // chặn hoặc giảm sát thương nhận vào
    {
        
    }
}
