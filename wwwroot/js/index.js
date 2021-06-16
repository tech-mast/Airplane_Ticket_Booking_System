// based on the selected option on tripType, show round trip or one way datepicker
async function selectTripType(){
    try {
        const tripType = document.querySelector("#tripType");
        let roundTripElements = document.querySelectorAll(".show-in-round-trip");
        let onWayTripElements = document.querySelectorAll(".show-in-one-way");

        if (tripType.options.selectedIndex === 0 ) {
            // round trip
         
            roundTripElements.forEach(e => {

                e.style.display = "initial";

              });
        
              onWayTripElements.forEach(e => {
                e.style.display = "none";
              });


              

        }
        else{
            // one way trip
        
            roundTripElements.forEach(e => {
               
                e.style.display = "none";
              });
        
              onWayTripElements.forEach(e => {
                e.style.display = "initial";
              });

            
        }

    } catch (error) {
        console.log("Can not find triptype element")
    }  
}

//Evenlistener for the select tag #tripType
const tripType = document.querySelector("#tripType");
tripType.addEventListener('click',()=>{
    console.log("#tripType change");
    selectTripType();
})


// Executive after the index page is loadded
selectTripType();//generate the initial view of the search for ticket form


//Function to verify if select box ReturnDate is same as /later than DepartureDate
let dDate= document.querySelector("#departureDate-round-trip");
if (dDate == null) {
  dDate = document.querySelector("#departureDate-one-way");
}
const rDate = document.querySelector('#returnDate');
const Dest = document.querySelector('#Destination');
const Origin = document.querySelector('#Origin');

const warningMsg = document.querySelector('#returnWarmingMsg');


function compareReturnDepart() {

  const rValue = Date.parse(rDate.value);
  const dValue = Date.parse(dDate.value);

  if (rValue === NaN || (rValue - dValue)<0 ) {
    rDate.style.color = "red";
    rDate.value = dDate.value;
    warningMsg.style.display ="initial";
  }

}

dDate.addEventListener('change',()=>{
  warningMsg.style.display ="none";
  rDate.style.color = "inherit";
    compareReturnDepart();
})

rDate.addEventListener('change',()=>{
  warningMsg.style.display ="none";
  rDate.style.color = "inherit";
  compareReturnDepart();
})



function getFlightData(origin,dest,departTime){
  dDat.value=departTime;
  Origin.vlaue = origin;
  Dest.value=dest;
}


