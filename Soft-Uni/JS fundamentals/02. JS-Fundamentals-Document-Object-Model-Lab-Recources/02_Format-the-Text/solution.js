function solve(){
let counter=0;
let newArray=[];
let index = 0;

let input = document.getElementById('input').textContent;

for (let i = 0; i < input.length; i++) {
  
  if (input[i]==='.') {
      counter++;
  }

  if (counter===3) {
    newArray.push(input.slice(i+1));
    index = i+1;
    counter=0;
  }
  
}
  let lastParagraph = input.slice(input.length-1);
  newArray.push(lastParagraph);


  for (let paragraphs of newArray){
    let paragraph=document.createElement('p');
    document.getElementById('output').appendChild(paragraph);
    paragraph.textContent=paragraphs;
}
}