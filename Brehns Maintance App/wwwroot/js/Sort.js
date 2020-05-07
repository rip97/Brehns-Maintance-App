function GetInputsToSort() {
    alert("button pressed");
    var amtLow;
    var list1 = document.getElementById("priceLow");
    var amtHigh; 
    var list2 = document.getElementById("priceHigh");

    for (var i = 0; i < list1.length; i++) {
        if (i = document.getElementById("priceLow").selectedIndex) {
            amtLow = list1[i];
            break;
        }
    }

    for (var i = 0; i < list2.length; i++) {
        if (i = document.getElementById("priceHigh").selectedIndex) {
            amtHigh = list2[i];
            break;
        }
    }

    alert("button pressed" + amtHigh + amtLow);
 
    
}
/*
function sortByPri(amtLow, amtHigh) {
    var table, rows, switchen, shouldWeSwitch, row1, row2
    table = document.getElementById("table")
    switchen = true;

    while (switchen) {
        switchen = false;
        rows = table.rows;
        for (var i = 0; i < rows.length; i++) {
            shouldWeSwitch = false;
            row1 = rows[i].getElementById("amt")[0];
            row2 = rows[i].getElementById("amt")[0];

            

        }
    }
}*/
