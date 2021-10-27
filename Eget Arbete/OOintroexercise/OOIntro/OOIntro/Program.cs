using OOIntro;
using System;

//1.Skapa en klass som heter Person. 
//Klassen ska ha en metod som heter Run som inte tar några parametrar och som inte returnerar något värde. 
//När metoden kallas på ska ”The person runs!” skrivas ut i konsolen.

//2.Kalla på metoden Run från din huvudexekvering av programmet

//3.Uppdatera klassen med en property som heter Speed som är av typen int
//och som har ett defaultvärde du väljer själv.

//4.Skriv om metoden Run som du skapade tidigare så att den i konsolen istället skriver
//”The person runs at {} km / h” där måsvingarna ska bytas ut mot värdet som finns
//lagrat i propertyn Speed.

//5.Kalla på din uppdaterade metod Run från huvudexekveringen av programmet.

//6.Skapa en ny klass som heter Backpack. Klassen ska ha en property som är av typen string[] 
//som heter Snacks och ha en längd på 3. Populera arrayen i constructorn för Backpack-klassen 
//med följande strängar: ”Cake”, ”Sandwich” och ”Chips

//7.På backpack - klassen skapar du ännu en property som är av typen sträng och som heter
//BackpackBrand.

//8. Uppdatera constructorn för Backpack så att den kan ta emot ett sträng-värde 
//    som tilldelas till propertyn BackpackBrand. Om inget värde anges ska BackpackBrand
//    sättas till ”Fjallraven”.

//9.Lägg till en property på klassen Person som heter Backpack och är av typen Backpack .

//10.Uppdatera constructorn för Person så att den kan ta in ett objekt av typen Backpack och
//tilldela sin backpack-property med objektet. Om inget objekt anges i constructorn ska en ny Backpack-instans skapas med default-värden.

//11. Skapa en metod på Person-klassen som heter LookInBag som skriver följande till konsolen
//”The person looks in the {} and sees x, y, z” där x, y z byts ut mot innehållet i ryggsäcken och
//måsvingarna mot märket på ryggsäcken.

//12. Kalla på din nya metod från huvudexekveringen av programmet.

//13. Skapa en ny metod på Person-klassen som heter Eat. Slumpa ut något av sakerna du har
//i väskan och skriv ut på skärmen: ”The person takes a bite of {}.” där måsvingarna är det
//framslumpade snacket i väskan.

//14. Kalla på din nya metod från huvudexekveringen av programmet.

var person = new Person();
person.Run();
person.LookInBag();
person.eat();