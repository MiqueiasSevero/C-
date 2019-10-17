
<?php
        include_once("conexao.php");
        #query
        $sql = "select * from tbl_usuario;";
       $res = $con->query($sql);

       while($row = $res->fetch_array(MYSQLI_NUM)){

      $dados[] = array('id'=>$row[0],'nome'=> $row[1]);

       }
     //  print_r($dados);

       //json_encode(array,opcional(true)) -- cria um arquivo resposta no json 
        $json = json_encode($dados,true);
       // echo "<br>";
        echo $json;
        
       //json_decode(json) - converte em array


?>