function GetInputsToSort() {
    alert("button pressed");
    var amtLow = Number(document.getElementById("priceLow").selectedIndex);
    var amtHigh = Number(document.getElementById("priceHigh").selectedIndex);
    sortByPri(amtLow, amtHigh);

 
    
}

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
}
