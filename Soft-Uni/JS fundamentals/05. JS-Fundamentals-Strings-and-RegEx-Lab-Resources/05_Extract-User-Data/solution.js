function solve() {
  let inputArr = JSON.parse(document.getElementById('arr').value);
  let resultElement = document.getElementById('result');
  let paragraphElement = document.createElement('p');
  let dashElement = paragraphElement.cloneNode();
  dashElement.textContent='- - -'

  let pattern = /^([A-Z][a-z]* [A-Z][a-z]*) (\+359 [0-9]{1} [0-9]{3} [0-9]{3}|\+359-[0-9]{1}-[0-9]{3}-[0-9]{3}) ([a-z0-9]+@[a-z]+.[a-z]{2,3})$/;

  inputArr.forEach(element => {
    let match = pattern.exec(element);

    if (match) {
      let firstParagraph=document.createElement("p");
      firstParagraph.textContent="Name: " + macth[1];
      resultElement.appendChild(firstParagraph);
      let secondParagraph=document.createElement("p");
      secondParagraph.textContent="Phone Number: " + macth[2];
      resultElement.appendChild(secondParagraph);
      let thirdParagraph=document.createElement("p");
      thirdParagraph.textContent="Email: " + macth[3];
      resultElement.appendChild(thirdParagraph);
    }

    else{
      resultElement.appendChild(invalidDataParagraph.cloneNode)
    }

    resultElement.appendChild(dashElement.cloneNode(true))
  });

}