
 function register() {
  let username = document.getElementById('username').value;
  let email = document.getElementById('email').value;
  let password = document.getElementById('password').value;

let regexPattern = new RegExp(/(.+)@(.+).(com|bg)/);
let matchEmail = regexPattern.test(email);

  if (matchEmail && username && password) {
 
    setTimeout(()=>{
    
    let message = document.getElementById('result');
    let successMessage = document.createElement('h1');
    successMessage.textContent = 'Successful Registration!'
    message.appendChild(`Username: ${username}`);
    message.appendChild(`Email: ${email}`);
    message.appendChild(`Password: ${password.length}`);
    },(5000));
  }
 }
