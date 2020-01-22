function solve() {
   let buttons = Array.from(document.getElementsByTagName('button'));
   buttons.forEach(button=>{button.addEventListener('click', showProfile)});

   function showProfile(event){

let button = event.target;
let profile = button.parentNode;

let moreInformation = profile.getElementsByTagName('div')[0];
let lockStatus = profile.querySelector('input[type="radio"]:checked').value;


if (lockStatus === 'unlock') {
   if (button.textContent === 'Show more') {
       moreInformation.style.display = 'inline-block';
       button.textContent = 'Hide it';
   } 
   
   else if (button.textContent === 'Hide it') {
       moreInformation.style.display = 'none';
       button.textContent = 'Show more';
   }
}
   }
} 