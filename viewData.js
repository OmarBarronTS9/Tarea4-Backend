//var nc;
function showData(myData){
    document.getElementById("Datos").innerHTML = "";
    for(let item of myData){
        console.log(item);
    var elementHeader = document.createElement('h4');
    elementHeader.innerHTML = "Id del Cliente: " + item.customerId +"<br>"+"Nombre Del Cliente: "+ item.contactName;
    document.getElementById('Datos').appendChild(elementHeader);
    }
}

