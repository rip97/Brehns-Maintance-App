function GetInputsToSort()
{
    var amtLow;
    var list1 = document.getElementById("priceLow");
    var amtHigh; 
    var list2 = document.getElementById("priceHigh");
    
    for (var i = 0; i < list1.length; i++) {
        if (i == document.getElementById("priceLow").selectedIndex) {
            amtLow = list1[i].value;
            break;
        }
    }

    for (var i = 0; i < list2.length; i++) {
        if (i == document.getElementById("priceHigh").selectedIndex) {
            amtHigh = list2[i].value;
            break;
        }
    } 

    sortByPri(amtLow, amtHigh);
}

function sortByPri(amtLow, amtHigh)
{
    var table, rows, 
    table = document.getElementById("table");
    rows = table.getElementsByTagName("tr");

    for (var i = 1; i < rows.length - 1; i++)
    {
        data = rows[i].getElementsByTagName("td")[2];
        val = data.outerText;
        val = val.replace("$", "");
        val = Number(val);
        amtLow = Number(amtLow);
        amtHigh = Number(amtHigh);
        if (val > amtHigh  || val < amtLow ){

            rows[i].style.display = "none";
        }
        

    }
  
}
