function solve(arr){
let result = arr.sort((a,b)=> {return a.length-b.length|| a.localeCompare(b)});
console.log(result.join('\n'));

}