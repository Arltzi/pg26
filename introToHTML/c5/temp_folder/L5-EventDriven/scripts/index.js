// Copyright (C) 2024, Scott Henshaw
import { TableManager } from "./TableManager.js";

class App {

    constructor() {
        // TODO: Setup all the screens and application data
        this.tick = 0;
        this.gameOver = false;
        this.gameBoard = new TableManager( 12 );

        this.crazyMessage = "This is a box";

        // Inject the table markup into the actual DOM
        let element = document.querySelector("#gamemap");
        element.innerHTML = this.gameBoard.generateMarkup();

        this.initAllHandlers();
    }

    initAllHandlers() {

        document.querySelector("#play-btn")
            .addEventListener("click", event => {

                document.querySelector("#splash-screen")
                    .classList.add("hide");

                document.querySelector("#game-screen")
                    .classList.remove("hide");
            })
    }

    run() {

        while (!this.gameOver) {

            this.update();
            this.render();
        }
    }

    update() {

        if (this.tick > 10)
            this.gameOver = true;

        this.gameBoard.markCellHit( 3, 4 );
        this.tick++;
    }

    render() {
    }
}

// Actually run the game
const game = new App();
game.run();
