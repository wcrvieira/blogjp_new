"use client"
import { useState } from "react";
import Link from 'next/link';

function DeleteButton({ onClick }) {
  const [confirm, setConfirm] = useState(false);


  const handleDelete = () => {
    
    if (confirm) {
      onClick();
    } else {
      setConfirm(true);
    }
   
  };
  
  return (
    
    <button onClick={handleDelete}>
      {confirm ? "Tem certeza?" : "Excluir cadastro"}
      
    </button>
    
  );
}

export default DeleteButton;


   
  



