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