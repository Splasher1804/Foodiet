//Miu Mihai Florian 4LF791B
//1
function getMonthName(month){
    const d = new Date();
    d.setMonth(month-1);
    const monthName = d.toLocaleString("default", {month: "long"});
    return monthName;
  }
  
 //const zi    = new Date();  
 //const luna  = new Date();  
 //const an    = new Date();

const date_formats1 = (zi, luna, an) => zi+" "+getMonthName(luna)+" "+an;
const date_formats2 = (zi, luna, an) => an+"-"+luna+"-"+zi;
const date_formats3 = (zi, luna, an) => an+"/"+luna+"/"+zi;
const date_formats4 = (zi, luna, an) => zi+"/"+luna+"/"+an;
const date_formats5 = (zi, luna, an) => luna+"/"+zi+"/"+an;
const date_formats = [date_formats1, date_formats2, date_formats3, date_formats4, date_formats5]
console.log(date_formats);

date_formats.forEach(element => console.log(element(5,4,1981)));
//2
const meal = {
    id:1,
    description: "Breakfast"
    };
    const updatedMeal = {
    ...meal,
    description: "Brunch",
    calories:600
    };
//
var id = meal.id;
var descr1 = meal.description;
var descr2 = updatedMeal.description

const functionAsObjectProperty = (id, description) => "Id: "+id+"\nMasa: "+description;
const Masa = [functionAsObjectProperty];
console.log(Masa);

Masa.forEach(element => console.log(element(id, descr1)));
Masa.forEach(element => console.log(element(id, descr2)));

//3
const dailymeal = [
    {description: "Mic Dejun", calories: 1000},
    {description: "Pranz", calories: 750},
    {description: "Cina", calories: 500},
]
console.log("Mese inainte de total calorii", dailymeal);
var Total = 0;
dailymeal.forEach(element => Total+=element.calories)
console.log("Total calorii: ", Total);

