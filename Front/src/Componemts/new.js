import React , {useEffect} from "react";
import './Css/New.css'
import { Swiper, SwiperSlide } from 'swiper/react';
import { Navigation, Pagination, Scrollbar, A11y } from 'swiper';
import 'swiper/css';
import 'swiper/css/navigation';
import 'swiper/css/pagination';
import 'swiper/css/scrollbar';


const New =()=>{

  useEffect(()=>{

    const res = fetch('http://localhost:5101/api/Agents/last')
  

  },[])

return(

     <div id="new">
     
 <Swiper 
      id="swip"
      modules={[Navigation, Pagination, Scrollbar, A11y]}
      spaceBetween={5}
      slidesPerView={3}
      navigation
      pagination={{ clickable: true }}
      scrollbar={{ draggable: true }}
      //onSwiper={(swiper) => console.log(swiper)}
      //onSlideChange={() => console.log('slide change')}
    >
      <SwiperSlide >
       <div className="swipslide">
          <img  className="imgCar" src="https://i.gaw.to/vehicles/photos/06/43/064350_2015_toyota_Corolla.jpg?640x400"  /> 
          <h2 className="h2">Toyota corrolla </h2>
          <h3 className="h3">2015 . Diesel . 168 320km</h3>
          <h3 className="ph3">130000dhs</h3>
          </div>
      </SwiperSlide>
      <SwiperSlide >
        <div className="swipslide">
          <img className="imgCar" src="https://motorwheels.com/wp-content/uploads/2022/04/278460457_5292230210795174_8843777366840972413_n-large.jpg"  /> 
          <h2 className="h2">Hyandai Tucson </h2>
          <h3 className="h3">2016 . Diesel . 80 540km</h3>
          <h3 className="ph3">200000dhs</h3>
          </div>
       </SwiperSlide>
      <SwiperSlide >
      <div className="swipslide">
          <img className="imgCar" src="https://www.moteur.ma/media/photos/ads/resized/bmw-serie-3-926570.jpeg" /> 
          <h2 className="h2">Bmw serie 3</h2>
          <h3 className="h3">2012 . Essence . 185 000km</h3>
          <h3 className="ph3">120000dhs</h3>
          </div>
      </SwiperSlide>
      <SwiperSlide >
       <div className="swipslide">
          <img  className="imgCar" src="https://arc-anglerfish-arc2-prod-tbt.s3.amazonaws.com/public/KICYC6GGREI6TCHRIBWI6S7HAY.jpg" /> 
          <h2 className="h2">Audi A3 Sedan</h2>
          <h3 className="h3">2017 . Diesel . 200 000km</h3>
          <h3 className="ph3">160000dhs</h3>
          </div>
      </SwiperSlide>
    <br/>
    </Swiper>


     </div>
    

)



}



export default New