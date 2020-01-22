function solve() {
    let fromFieldValue = document.getElementById('from').value;
    let toFieldValue = document.getElementById('to').value;
    let suit = document.querySelector('#exercise > select').value;
    let button = document.querySelector('#exercise > button');

    let allCards = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    let cards = [];

    let firstIndex = allCards.indexOf(fromFieldValue);
    let lastIndex = allCards.indexOf(toFieldValue);

    console.log(firstIndex, lastIndex);

    for (let i = firstIndex; i <= lastIndex; i++) {
        
        let card={
            suit:unicode,
            value:allCards[i]
        }
        cards.push(card);
    }

    cards.forEach(element => {
        let divElement = document.createElement('div');
        let leftP = document.createElement('p');
        let middleP = document.createElement('p');
        let rightP = document.createElement('p');
        divElement.setAttribute('class', 'card');
        divElement.appendChild(leftP);
        divElement.appendChild(middleP);
        divElement.appendChild(rightP);
        leftP.innerHTML=card.suit;
        middleP.innerHTML=card.value;
        rightP.innerHTML=card.suit;
        resultElement.appendChild(divElement);
    });
    
    function getSuit(suitElement) {
        switch (suitElement) {
            case 0:
                unicode="&hearts;";
                break;
            case 1:
                unicode="&spades;";
                break;
            case 2:
                unicode="&diamond;";
                break;
            case 3:
                unicode="&clubs;";
                break;
        }
        return unicode;
    }

}