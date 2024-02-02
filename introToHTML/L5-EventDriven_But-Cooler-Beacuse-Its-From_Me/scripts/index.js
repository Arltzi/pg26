// Copyright (C) 2024, Scott Henshaw
import { TableManager } from "./TableManager.js";
import GameMap from "./GameMap.js";

class App {

    constructor( mapSize = 12) {
        // TODO: Setup all the screens and application data
        this.__private__ = {};
        this.tick = 0;
        this.gameOver = false;
        this.gameBoard = new TableManager( mapSize );
        this.playerA = new GameMap( mapSize );
        this.playerB = new GameMap( mapSize );

        // Inject the table markup into the actual DOM
        let element = document.querySelector("#gamemap");
        element.innerHTML = this.gameBoard.generateMarkup();

        this.screenElementList = [
            document.querySelector("#splash-screen"),
            document.querySelector("#game-screen"),
            document.querySelector("#player-divider")
        ];

        this.initAllHandlers();
    }

    get SplashScreen() { return this.screenElementList[App.SCREEN.SPLASH] }
    set SplashScreen( value ) { this.screenElementList[App.SCREEN.SPLASH] = value }

    static get SCREEN() {
        return {
            SPLASH: 0,
            GAME: 1,
            PLAYER_DIVIDER: 2,
            RESULTS: 4
        }
    }

    initAllHandlers() {

        document.querySelector("#play-btn").addEventListener("click", event => {

                //document.querySelector("#splash-screen")
                this.SplashScreen.classList.add("hide");

                document.querySelector("#game-screen")
                    .classList.remove("hide");
            });

        document.querySelector("#turn-over-btn")
            .addEventListener("click", event => {

                // TODO:  Player clicks this to signify turn over and
                // we need to bring up the screen between
                document.querySelector("#game-screen")
                    .classList.add("hide");

                document.querySelector("#player-divider")
                    .classList.remove("hide");
            });


        document.querySelector("#gamemap")
            .addEventListener("click", event => {

                let position = event.target;
                let row = parseInt(position.dataset.row);
                let col = Math.floor( position.dataset.col );
            });
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
