class MovementScript{
  
  Vector3 DefaultScale;
  DefaultScale = transform.localScale;
  
  void Update(){
      
        //continue crouching if the player is already crouching and holding the left control button
        //timer will affect this if statement if the player is not crouching and clicks the left control button
        if(Input.GetKey(") && (timer <= 0 || isCrouching)){ 
          transform.localScale = new Vector3(10, 10, 10);
          transform.position = new Vector3(0, 5, 0);
          //if I understood correctly, the two lines above were responsible for making a game object crouch
          timer = 3f; 
          isCrouching = true;
        }
        else
        {
          isCrouching = false;
          timer -= Time.deltaTime;
          //whatever code you had there that would make a game object stop crouching
          transform.localScale = DefaultScale;
        }    
  }
  

}
