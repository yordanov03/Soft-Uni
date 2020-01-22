function solve() {
	
	let buttons = document.getElementsByTagName('button');

	let sections= document.getElementsByTagName('section');
	let secondSection = sections[1];
	let thirdSection = sections[2];

	let firstButton = buttons[0];
	firstButton.addEventListener('click', function(){
		secondSection.style.display="block";
	});

	let secondButton = buttons[2];
	secondButton.addEventListener('click', function(){

		if (secondSection.style.display==='none') {
			
		}
		else{
			thirdSection.style.display="block";
		}
	});
}