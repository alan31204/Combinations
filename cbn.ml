(*Author: Yujie Liu*)
(*Partner: Po-Chun Chiu*)
(*CSC254 A1 OCaml Combination*)
(*Cbn takes a number k and a list
 * And returns the list of all combinations of k elements *)
let rec cbn k list =
    if k <= 0 then [ [] ]
    else match list with
         | [] -> []
         (* match list if the list is empty, return an empty list*)
         | h :: tl ->
            let list1 = List.map (fun l -> h :: l) (cbn (k-1) tl) in
            (* list1 contains all combinations of k elements that include h *)
            let list2 = cbn k tl in
            (* list2 contains all combinations that do not include h *)
            list1 @ list2;;

(* (newList j) constructs a list from 1 to j *)
let newList j =
    let rec temp n list =
      if n < 1 then list else temp (n-1) (n :: list)
    in temp j [] ;;

let printlist l =
        List.iter (Printf.printf "%d ") l;
        Printf.printf "\n"

let n = int_of_string Sys.argv.(2) and k = int_of_string Sys.argv.(1)
let answer = cbn k (newList n) 
let () = List.iter printlist answer

