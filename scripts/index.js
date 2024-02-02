import GridGenerator from "./gridGenerator.js";
import InputManager from "./input.js";

class App{
    constructor()
    {
        // constructors
        this.gridGenerator = new GridGenerator();
        this.inputManager = new InputManager();

        // a this im proud of. lets me add more nav buttons quickly and easily
        // used in the InitHandlersFromList function lower down
        this.toFromIDList = [
            ["#start-game-button", "#start-screen", "#setup-screen"],
            ["#change1", "#setup-screen", "#change-screen"],
            ["#change2", "#setup-screen", "#change-screen"],
            ["#change3", "#setup-screen", "#change-screen"],
            ["#change4", "#setup-screen", "#change-screen"],
            ["#to-gameplay", "#change-screen", "#gameplay-screen"],
            ["#fire-button", "#gameplay-screen", "#endgame-screen"],
            ["#restart", "#endgame-screen", "#start-screen"],
        ]
        this.InjectGridHTML();
        this.InitHandlersFromList();
    }

    InjectGridHTML(){
        // puts the generated grid in both the play and view board
        let playBoard = document.querySelector("#play-board");
        playBoard.innerHTML = this.gridGenerator.GenerateGrid();

        let viewBoard = document.querySelector("#view-board");
        viewBoard.innerHTML = this.gridGenerator.gridHTML;
    }

    InitHandlersFromList(){
        // really overcomplicated this for myself
        // writing this while tired didn't help, made many silly mistakes
        this.toFromIDList.forEach(element => {
            this.inputManager.ElemHidePage(element[0], element[1], element[2])
        });
    }

}

const game = new App();
