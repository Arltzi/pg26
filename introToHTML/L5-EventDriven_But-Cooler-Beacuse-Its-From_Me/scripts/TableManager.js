// Copyright (C) 2024 Scott Henshaw

const UNPLAYED = 0;

export class TableManager {

    constructor( size = 10 ) {

        this.map = {
            width: size,
            height: size,
            status: UNPLAYED
        }
    }

    generateMarkup() {
        // Build this for each row --> <tr><td></td></tr>
        let tableMarkup = this.generateHeader( this.map.width );

        // Build the body of the table
        for (let rows = 0; rows < this.map.height; rows++) {
            // Generate all the columns inside here
            tableMarkup += this.generateRow( this.map.width, rows );
        }

        return tableMarkup
    }

    generateHeader( width ) {
        // Generate the first row with column headers
        let tableMarkup = '<tr><td class="table-header"></td>';
        for (let cols = 1; cols < width; cols++) {
            // for each column
            tableMarkup += `<td class="table-header">${cols}</td>`
        }
        tableMarkup += "</tr>";

        return tableMarkup
    }

    generateRow( width, currentRow = 0 ) {

        let tableMarkup = "<tr>";
        for (let cols = 0; cols < width; cols++) {
            // for each column
            tableMarkup += this.generateCell( currentRow, cols );
        }
        tableMarkup += "</tr>"

        return tableMarkup
    }

    generateCell( row = 0, col = 0 ) {

        return `<td id="${this.cellId( row, col)}" data-row="${row}" data-col="${col}"></td>`;
    }

    cellId( row, col ) {

        return `row${row}-col${col}`;
    }

    markCellHit( row = 0, col = 0 ) {
        // TODO:  How to mark a cell hit???

        // Find a cell with a specific id?
        let element = document.querySelector(`#${this.cellId( row, col)}`);
        if (element != undefined) {
            // add a css class to the element
            element.classList.add("red")
        }
    }
}