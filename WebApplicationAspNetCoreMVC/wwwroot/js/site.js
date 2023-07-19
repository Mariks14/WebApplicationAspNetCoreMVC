// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
 function tableCreate() {
    const myDiv = document.body.createElement("div");
    myDiv.classList.add("mydiv");

    const myTable = document.createElement("table");
    myTable.classList.add("mytable");

    const headerRow = document.createElement("tr");
    headerRow.classList.add("myheader");

    const headerCell1 = document.createElement("td");
    headerCell1.textContent = "Info";
    headerRow.appendChild(headerCell1);

    const headerCell2 = document.createElement("td");
    const updateButton = document.createElement("button");
    updateButton.classList.add("mybtn");
    updateButton.textContent = "update";
    headerCell2.appendChild(updateButton);
    headerRow.appendChild(headerCell2);

    myTable.appendChild(headerRow);

    const rows = [
        ["ID:", "@ViewData['id']"],
        ["Company name:", "@ViewData['name']"],
        ["address:", "@ViewData['address']"],
        ["City:", "@ViewData['city']"],
        ["State:", "@ViewData['state']"],
    ];

    for (const row of rows) {
        const tableRow = document.createElement("tr");

        const cell1 = document.createElement("td");
        cell1.classList.add("brdNone");
        cell1.textContent = row[0];
        tableRow.appendChild(cell1);

        const cell2 = document.createElement("td");
        cell2.textContent = row[1];
        tableRow.appendChild(cell2);

        myTable.appendChild(tableRow);
    }

    myDiv.appendChild(myTable);
}

function myfoo(){
    alert("Hello");
}