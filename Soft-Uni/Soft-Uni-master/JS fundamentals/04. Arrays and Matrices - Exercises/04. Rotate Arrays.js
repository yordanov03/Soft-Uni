function solve(arr){
    let rotations = Number(arr.pop());

    for (let i = 0; i < rotations; i++) {
        let lastElement = arr[arr.length-1];
        arr.pop();
        arr.unshift(lastElement);
    }
    console.log(arr.join(" "));
}

solve(
    ['Banana', 
    'Orange', 
    'Coconut', 
    'Apple', 
    '15']
    

)