function solve(arr){
    let element = Number(arr.pop());

    for (let i = 0; i < arr.length; i+=element) {
        console.log(arr[i]);
        
    }
}

solve(['5', 
'20', 
'31', 
'4', 
'20', 
'2']
);