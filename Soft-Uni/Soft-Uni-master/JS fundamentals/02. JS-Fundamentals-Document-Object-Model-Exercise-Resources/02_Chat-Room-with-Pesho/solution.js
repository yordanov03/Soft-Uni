function solve() {
 
    let buttons = Array.from(document.getElementsByTagName('button')).forEach(button=>{button.addEventListener('click', chatMessage()
    )});
    let inputFields = Array.from(document.getElementsByTagName('input'));

   function chatMessage(e){

    let divElement = document.createElement('div');
    let spanElement = document.createElement('span');
    let pElement = document.createElement('p');

    let senderBtn= event.target.name;

    if (senderBtn==='peshoBtn') {
        spanElement.textContent = 'Pesho';
        pElement.textContent = document.getElementById('peshoChatBox').value;
        divElement.style.textAlign='right';
    }

    else if(senderBtn==='myBtn'){
        spanElement.textContent = 'Me';
        pElement.textContent =  document.getElementById('myChatBox').value;
        divElement.style.textAlign='left'
    }

    divElement.appendChild(spanElement);
    divElement.appendChild(pElement);

    document.getElementById('chatChronology').appendChild(divElement);

    inputFields[0]='';
    inputFields[1]='';
   }
}