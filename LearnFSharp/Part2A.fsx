// this part is about F# Lists

// zoals eigenlijk iedere moderne bruikbare taal is er wel een standaard vorm om collections bij te houden.
// Een van de vormen en veelgebruikte vormen in F# is de fsharp list
// de list in F# is een immutable linked list. Deze is wat betreft werking een heel eind vergelijkbaar met de linked list die we in pyhton hebben gemaakt en gebruikt.

//decalre an empty list
let emptyList = []

// with items
let numbers = [1;35;2]

// let op dat de types in de match altijd matchen Het volgende zal bijvoorbeeld niet compilen
//let errors = ["hoi";24]

// type declaratie
// net zoals alle ander andere waardes hebben lijsten ook een type declaratie. Een lijst is daarin iets anders dan wat we tot nu toe hebben gezien hier.
// Dit komt omdat het een generic type is. Bij een generic type bepaal je pas op het moment dat je het gebruikt welke types er worden gebruikt. 
// Om het beter te begrijpen gaan we maar gewoon aan de slag

let numbers': int list = [25;12]
let strings: list<string> = ["hello"; "world"]

// list range
// F# heeft ook een syntax om snel een lijst met getallen te genereren:
// [start..[step]..stop]

let unevensBelow100 = [1..2..100]

// loops worden zo weinig mogelijk gebruikt dit komt door dat dit vaak mutabiliteit vereist. In plaats daarvan worden vaak HOF gebruikt of recursie.
// hieronder een voorbeeld van de generate functie

let rec generate start stop =
    if start > stop then
        []
    else
        start :: generate (start+1) stop


(*
let rec generate start stop =
# the rec keywoord is nodig omdat je anders in F# de let binding niet recursief mag aanroepen
    if start > stop then
    # check for base case
        []
        # return een lege lijst als het doel behaalt is
    else
        start :: generate (start+1) stop
        # :: operater laat je een nieuwe waarde vooraan de bestaande lijst zetten
*)

// maak nu een generate functie waarbij je de stapgroote aangeeft. Hoeft geen negatieve stapgroote te ondersteuen maar mag wel

// generate: int -> int -> int -> list<int>


// nu we hebben gezien hoe je een lijst kunt aanmaken gaan we ook in op hoe we een lijst kunnen uitlezen

let rec productOfList (l: int list) : int =
    match l with
    | [] -> 1
    | head::tail -> head * productOfList tail

(*
let rec productOfList (l: int list) : int =
# functie inclusiev signature
    match l with
    # een nieuwe concept namelijk patern matching
    | [] -> 1
    # de case kan een lege lijst zijn in dat geval return 1
    | head::tail -> head * productOfList tail
    # de andere case kan zijn dat de lijst een head en een tail heeft. Dit is een specifieke manier om een lijst te matchen
    # van de head weten we dat het een int is daarom vermenigvuldigen we het met het product van de rest van de lijst.
*)

let rec productOfList' (l: int list) : int =
    match l with
    | [] -> 1
    | 0::tail -> productOfList tail
    | head::tail -> head * productOfList tail

// je kan ook specifiekere dingen matchen bijvoorbeeld als de head een '0' is wil ik dat dit genegeerd wordt zodat er geen 0 uit kan komen door een 0 in de lijst.

// Dit is een lastig onderwerp probeer er even mee aan de slag en probeer zelf een aantal varianten te maken.
// Je zou bijvoorbeeld de volgende functies kunnen maken:

let rec printAll l =
    // alles printen kan met printfn "%A" var
    failwith "not implemented"
    

let rec multiplyAllBy (n:int) (l:int list) : int list =
    failwith "not implemented"

let rec mapIntToInt (f:int -> int) (l:int list) : int list =
    failwith "not inmplmented"

//mischien nog te lastig maar probeer een generieke map te implementeren
// geef zelf de type signature mee
let rec map f l =
    failwith "not implemented"

let rec filterOdd (l: int list) : int list =
    failwith "not implemented"
