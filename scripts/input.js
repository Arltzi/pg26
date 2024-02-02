export default class InputManager
{

    // this class will almost certainly expand once I write the combat functionality
    // not even gonna outline that yet, pretty tired of js and html
    ElemHidePage(button, currentPageID, targetPageID)
    {
        document.querySelector(button).addEventListener("click", event =>
        {
            console.log("pressed");
            document.querySelector(currentPageID).classList.add("hide");
            document.querySelector(targetPageID).classList.remove("hide");
        }
        );
    }
}