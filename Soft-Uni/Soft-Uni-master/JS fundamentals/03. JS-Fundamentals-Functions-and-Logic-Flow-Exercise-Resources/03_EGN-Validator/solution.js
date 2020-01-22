function validate() {
    let button = document.getElementsByTagName('button')[0];
    let egn = 0;

    button.addEventListener('click', generateEGN);

    function generateEGN(){
       let year = document.getElementById('year').value;
       let date = ('0'+ document.getElementById('date').value).slice(-2);
       let gender = document.getElementById('male').checked?2:1;
       var getMonth = ()=>{
           months={
            January: '01',
            February: '02',
            March: '03',
            April: '04',
            May: '05',
            June: '06',
            July: '07',
            August: '08',
            September: '09',
            October: '10',
            November: '11',
            December: '12',
           };
           return months[document.getElementById('month').value];
       }
       let weights = [2, 4, 8, 5, 10, 9, 7, 3, 6];
       let region = document.getElementById('region').value;

       if (year>1899 && year<2101 && region>42 && region<1000) {
           egn = year.slice(-2) + getMonth() + date + region.slice(0,2)+gender;

           let sum = 0;

           for (let i = 0; i < egn.length; i++) {
               sum += egn[i] * weights[i]
               
           }
           let lastNumber = sum%11 >9? 0: sum%11;
           egn+=lastNumber;
           document.getElementById('egn').textContent = `Your EGN is: ${egn}`;
       }
       
       
    }
}