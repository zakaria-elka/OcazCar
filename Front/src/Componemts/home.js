import React , {useState} from "react";
import "./Css/Home.css"
import NavBar from "./Navbar";
import New from "./new";



const Home =()=>{



return(

<div className='homeapp'>
       <NavBar/>
      <div className='txt'>
        <p >Nouvelle Plateforme de voiture Ocaz</p>
        <div id="inputDiv">  

<select id="input"  name="pets" >
    <option value="">--Select Budget--</option>
    <option value="100000">moins de 100.000</option>
    <option value="150000">moins de 150.000</option>
    <option value="200000">moins de 200.000</option>
    <option value="250000">moins de 250.000</option>
    <option value="300000">moins de 300.000</option>
    <option value="350000">moins de 350.000</option>
    <option value="400000">moins de 400.000</option>
    <option value="450000">moins de 450.000</option>
    <option value="500000">moins de 500.000</option>
    <option value="1000000">moins de 1.000.000</option>
    
</select>

        <button id="button"><img src={require("./images/search.png")}  width={20} height={20}/></button>
        </div>
      </div>
      <New/>
      

    </div>




)

}

export default Home



