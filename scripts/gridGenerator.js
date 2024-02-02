// Copyright 2024 Lev Zitron all rights reserved

export default class GridGenerator
{
    constructor(size = 10)
    {
        this.gridSize = size;
        this.gridHTML = '';
    }

    GenerateGridHead()
    {
        // create the top row of cells, theyre just the coordinate cells that let the player communicate about columns
        // just realized, theyre completely unnecesarry in online battleships, but its nice to leave them in
        // very easily modifiable to remove the starting 0, but to me it has a charm to it
        let gridTopRow = '<tr>';
        for (let index = 0; index < this.gridSize + 1; index++) {
            gridTopRow += `<td class="grid-position-title">${index}</td>`;
        }
        gridTopRow += '</tr>\n';
        this.gridHTML += gridTopRow;
    }

    GenerateRow(rowNumber)
    {
        // fun debugging this String.fromCharCode function. i naively assumed 0 was lowercase a. hahahahahaha.
        let gridRows = '<tr><td class="grid-position-title">' + String.fromCharCode(rowNumber + 64) + '</td>';
        for (let index = 0; index < this.gridSize; index++) {
            gridRows += '<td class="cell"></td>';
        }
        gridRows += '</tr>\n';
        this.gridHTML += gridRows;
    }

    GenerateGrid()
    {
        // i know its wrong to write functions that modify members instead of returning, but I like it...
        this.GenerateGridHead();
        for (let index = 1; index <= this.gridSize; index++) {
            this.GenerateRow(index);
        }
        return this.gridHTML;
    }
}