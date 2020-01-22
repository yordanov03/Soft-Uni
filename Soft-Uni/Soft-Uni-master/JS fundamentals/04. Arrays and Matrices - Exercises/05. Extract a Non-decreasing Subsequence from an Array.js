function solve(arr){

    let maxNum = 0;

    for (let i = 0; i < arr.length; i++) {
        
        if (arr[i]>=maxNum) {
            maxNum = arr[i];
            console.log(arr[i]);
        }
        
    }
}
solve(
    [1, 
        3, 
        8, 
        4, 
        10, 
        12, 
        3, 
        2, 
        24])
         
