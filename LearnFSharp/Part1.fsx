
// Arithmetic en boolean operators werken eigenlijk net zoals die werken in de meeste talen werken. Probeer wel even de equality operator die is net iets anders dan je gewent bent
// probeer er hieronder een paar uit
25*3

// om waardes later terug te vinden kan je een let binding gebruiken wijs de uitkomsten van een aantal expresions toe aan een een identifier
// https://docs.microsoft.com/en-us/dotnet/articles/fsharp/language-reference/functions/let-bindings
let x = 10

// functies
// ook functies worden gedeclareerd met een let binding
// let <name_function> <param1> <param2> <etc>

let printNumber n =
    printfn "%i" n

// in f# hoef je niet expliciet te returnen maar wordt de waarde op de laatste regel van de branch gereturnt dus bijv:
let isEven n =
    if n%2=0 then
        true
    else
        false

// maar een aantal functies met en zonder branching


// Type Inference en types
// https://docs.microsoft.com/en-us/dotnet/articles/fsharp/language-reference/type-inference
// Je hebt tot nu toe nog niet gezien dat er types worden aangegeven. Ondanks dat F# net als bijv C# en Java een staticly typed language is.
// Dit komt door dat F# type inference heeft. Dit betekent dat als je de type niet aangeeft De compiler zelf het type probeert te bepalen.
// Je kan het ook zelf doen om verschillende redenen: 1. Het duidelijker voor jezelf of voor andere met welke types je werk 2. F# kiest types die jij niet wilt
// 3. F# komt er hellemaal niet uit

let add a b =
    a + b
// geeft signature:
// val add : a:int -> b:int -> int

// wat nu als je een concat functie wilt hebben?
// je kan het expliciet angeven welke types je wilt anders zal de functie niet werken:

let concat (a: string) (b: string) : string =
    a + b

// val concat : a:string -> b:string -> string

// met (a:string) geef je aan dat je een argument a hebt van het type string
// met de laatste :string geef je aan wat voor type de functie zal returnen
// In dit geval zou F# als je op een plek aan geeft dat het een string is slim genoeg zijn om te bepalen dat de rest ook een string zal zijn.
// Maak nu een paar functies aan te maken waar bij je wel en niet de tyeps aangeeft kijk of je een een aantal voorbeelden kan bedenken waarbij het ook nodig is.

// types voor functies
// types voor functies heb je deels al gezien maar worden gedaan door middel van pijltjes dus add is "int -> int -> int"
// dit wil zeggen dat je een functie hebt die als input een int heeft en een functie returnt van "int -> int". 
// Deze functie kan vervolgens weer een int nemen om vervolgens het eindresultaat als een int terug te geven


// HOF functies
// F# is niet voor niks een een functinele taal dus uiteraard kan je ook HOF gebruiken hier een voorbeeld is de de printNumber

let printNumber' : int -> Unit =
    printfn "%i"

// een normale functie is dat eigenlijk ook als het meerdere argumenten heeft zie bijvoorbeeld de add functie die valt op die manier prima om te bouwen tot een add1
let add1 = add 1
// of
let add2 = add 2
// of 
let startWithDash = concat "- "

// probeer nu een aantal HOF te maken. Probeer ook met een idee te komen voor een HOF die een functie als argument gebruikt



// Als je feedback op je werk wilt of vragen hebt stuur mij dan direct een bericht of gebruik het isue systeem. Als je voobeeld code hebt waar om het gaat dan is een link altijd erg praktische.




