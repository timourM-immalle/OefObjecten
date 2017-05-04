// Your code here!
var personen = [];

//1e manier
var p1 = {};
p1.naam = "Joske";
p1.leeftijd = 13

personen.push(p1);

//2e manier
var p2 = { naam: "Jantje", leeftijd: 15 };
personen.push(p2);

//3e manier
personen.push({ naam: "mieke", leeftijd: 15 });

personen.forEach(p => console.log(p.naam + " is " + p.leeftijd + " jaar oud.")); //p => ... = function(p) { return ... }
/////////////////////////////////////////
var artikels = [];

var artikel1 = { naam: "tafel", eenheidsprijs: 399.00, aantal: 1 };
var artikel2 = { naam: "stoel", eenheidsprijs: 79.00, aantal: 4 };
artikels.push(artikel1);
artikels.push(artikel2);

artikels.forEach(function (a) {
    var totaalprijs = a.eenheidsprijs * a.aantal;
    console.log(a.naam + "kost € " + a.eenheidsprijs + "/stuk. Men koop er " + a.aantal + " van aan en dus kost het in totaal € " + totaalprijs);
});