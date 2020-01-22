function solve(arr){
 var result = [];
 console.log(arr);

 for (let i = 0; i < arr.length; i++) {
     
    if (arr[i]=='add') {
       result.push(i+1); 
    }
     
 }

 if (result.length===0) {
     console.log("Empty");
 }

 else{
    console.log( result.join("\n"));
 }
}

solve(
    ['add', 
    'add', 
    'remove', 
    'add', 
    'add']
    
);