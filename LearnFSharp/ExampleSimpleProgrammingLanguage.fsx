type expressionNumber =
    | Number of int
    | Add of expressionNumber * expressionNumber
    | Diff of expressionNumber * expressionNumber
    | Times of expressionNumber * expressionNumber

let n i = Number(i)

type expressionCompare =
    | Equel of expressionNumber * expressionNumber
    | SmallerThen of expressionNumber * expressionNumber
    | GreaterThen of expressionNumber * expressionNumber
let (.=) a b = Equel(a,b)
let (.<) a b = SmallerThen(a, b)
let (.>) a b = GreaterThen(a, b)

type expressionBool =
    | Bool of bool
    | Compare of expressionCompare
    | AND of expressionBool * expressionBool
    | OR of expressionBool * expressionBool
    | NOT of expressionBool

let (..<) a b = Compare(a .< b)

type expression =
    | Num of expressionNumber
    | IF of expressionBool * THEN * ELSE // predicate then else
and THEN = 
    THEN of expression
and ELSE = 
    ELSE of expression

let nn i = Num(Number(i))

let rec executeNumber en =
    match en with
    | Number(n) -> n
    | Add(ex1,ex2) -> executeNumber ex1 + executeNumber ex2
    | Diff(ex1, ex2) -> executeNumber ex1 - executeNumber ex2
    | Times(ex1, ex2) -> executeNumber ex1 * executeNumber ex2

let executeCompare ec =
    match ec with
    | Equel(e1,e2) -> Bool(executeNumber e1 = executeNumber e2)
    | SmallerThen(e1,e2) -> Bool(executeNumber e1 < executeNumber e2)
    | GreaterThen(e1,e2) -> Bool(executeNumber e1 > executeNumber e2)

let rec ExecuteBool eb =
    match eb with
    | Bool(b) -> b
    | Compare(ec) -> ExecuteBool (executeCompare ec)
    | AND(e1,e2) -> ExecuteBool e1 && ExecuteBool e2
    | OR(e1,e2) -> ExecuteBool e1 || ExecuteBool e2
    | NOT(e) -> ExecuteBool e

let rec execute ex =
    match ex with
    | Num(ne) -> executeNumber ne
    | IF(eb,th,el) -> 
        if ExecuteBool eb then 
            execute (match th with |THEN(th) -> th) 
        else 
            execute (match el with |ELSE(el) -> el)

let program = 
    IF(n(29) ..< n(30),
        THEN(nn(20)), 
        ELSE(Num(Add(n(10),n(28)))))

program |> execute
