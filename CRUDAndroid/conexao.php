<?php

        //constante 


        define("servidor","localhost");
        define("banco","XAMARIN_ANDROID");
        define("porta","3306");
        define("user","root");
        define("senha","");

    //conexão com o banco

    $con =  new mysqli(servidor,user,senha,banco,porta);

    if($con->connect_error){
        echo $con->connect_error;

    }else{
       // echo "conectado !";
    }



?>