import React, {useState,useEffect} from "react";
import NavBar from "./Navbar";
import "./Css/offer.css"




   

const url= new URLSearchParams(window.location.search)
const price=url.get('price');




const GetOffer=()=>{
        

 const [results,setResults]=useState({})       
 useEffect(()=>{

    fetch({
        method: "get",
        url: "http://localhost:5000/api/packs/pref/"+price,

      })
            .then((res)=>setResults(res.data))
            .then(console.log(results))

    },[])

    return(

        <div>
    <NavBar/>
<div className="div">    
<a href="#"  class="vcard  flex flex-col items-center bg-white border border-gray-200 rounded-lg shadow md:flex-row md:max-w-xl hover:bg-gray-100 dark:border-gray-700 dark:bg-gray-800 dark:hover:bg-gray-700">
    <img class="object-cover w-full rounded-t-lg  md:h-auto md:w-48 md:rounded-none md:rounded-l-lg" src="https://motorwheels.com/wp-content/uploads/2022/04/278460457_5292230210795174_8843777366840972413_n-large.jpg" alt="" />
    <div class=" flex flex-col justify-between p-4 leading-normal">
        <h5 class="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white">Hyandai Tucson</h5>
        <p class="mb-3 font-normal text-gray-700 dark:text-gray-400">2016 . Diesel . 80 540km<br/>
        4cylindre 2l avec 200hp 320Nm</p>
        <h5 class="mb-3 font-normal text-red-500">200000dhs</h5>
        <h5 class="mb-2 text-2xl font-bold tracking-tight text-yellow-900">0644726355</h5>
    </div>
</a>
<a href="#"  class="vcard  flex flex-col items-center bg-white border border-gray-200 rounded-lg shadow md:flex-row md:max-w-xl hover:bg-gray-100 dark:border-gray-700 dark:bg-gray-800 dark:hover:bg-gray-700">
    <img class="object-cover w-full rounded-t-lg  md:h-auto md:w-48 md:rounded-none md:rounded-l-lg" src="https://arc-anglerfish-arc2-prod-tbt.s3.amazonaws.com/public/KICYC6GGREI6TCHRIBWI6S7HAY.jpg" alt="" />
    <div class=" flex flex-col justify-between p-4 leading-normal">
        <h5 class="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white">Audi A3 Sedan</h5>
        <p class="mb-3 font-normal text-gray-700 dark:text-gray-400">2017 . Diesel . 200 000km<br/>
        5cylindre 2l avec 220hp 400Nm</p>
        <h5 class="mb-3 font-normal text-red-500">160000dhs</h5>
        <h5 class="mb-2 text-2xl font-bold tracking-tight text-yellow-900">0645278899</h5>
    </div>
</a>
<a href="#"  class="vcard  flex flex-col items-center bg-white border border-gray-200 rounded-lg shadow md:flex-row md:max-w-xl hover:bg-gray-100 dark:border-gray-700 dark:bg-gray-800 dark:hover:bg-gray-700">
    <img class="object-cover w-full rounded-t-lg  md:h-auto md:w-48 md:rounded-none md:rounded-l-lg" src="https://www.moteur.ma/media/photos/ads/resized/bmw-serie-3-926570.jpeg" alt="" />
    <div class=" flex flex-col justify-between p-4 leading-normal">
        <h5 class="mb-2 text-2xl font-bold tracking-tight text-gray-900 dark:text-white">Bmw serie 3</h5>
        <p class="mb-3 font-normal text-gray-700 dark:text-gray-400">2012 . Essence . 185 000km<br/>
        6cylindre 3l avec 320hp 440Nm</p>
        <h5 class="mb-3 font-normal text-red-500">125000dhs</h5>
        <h5 class="mb-2 text-2xl font-bold tracking-tight text-yellow-900">0744163356</h5>
    </div>
</a>

</div>
</div>

    )

}








export default GetOffer