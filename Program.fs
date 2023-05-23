//open System

//let rec fu a =
//    if a < 10 then
//        printfn $"{a}"
//    else
//        fu (a / 10)
//fu 2344

//let Data = ["hkds"; "1e21"; "joda"; "dasDO"]
//let Add = "k"
//let NewData = List.map (fun x -> x + Add) Data
//for i in 0..NewData.Length-1 do 
//    printf $"{NewData[i]} "

//let GetMin acc elem =
//    if String.length acc < String.length elem then
//        acc
//    else
//        elem
//let h = ["sad"; ""; "happy"]
//let NewNewData = List.fold GetMin h[0] h
//printfn $"{NewNewData}"