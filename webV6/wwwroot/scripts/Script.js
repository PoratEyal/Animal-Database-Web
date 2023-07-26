document.addEventListener("DOMContentLoaded", pageLoad);

function pageLoad() {
    BtnMove();
    detailsBtn();
}

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

// funcs for the nevigation bar
function BtnMove() {
    let catlogBtn = document.querySelector(".catalogBtn");
    catlogBtn.addEventListener("click", CatalogClick);

    let administratorBtn = document.querySelector(".administratorBtn");
    administratorBtn.addEventListener("click", AdministratorClick);

    //let imgLogo = document.querySelector(".imgLogo");
    //imgLogo.addEventListener("click", HomePageClick);

    let homeBtn = document.querySelector(".homeBtn");
    homeBtn.addEventListener("click", HomePageClick);
}

function AdministratorClick() {
    window.location.href = '/Home/AdministratorPage/';
}
function CatalogClick() {
    window.location.href = '/Home/CatalogPage/';
}
function HomePageClick() {
    window.location.href = '/Home/HomePage/';
}

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

//funcs for the Catalog page

//find the details btn and set to him a click function
function detailsBtn() {
    let detailBtn = document.querySelectorAll(".DetailBtn");
    for (let i = 0; i < detailBtn.length; i++) {
        detailBtn[i].addEventListener("click", DetailsClick);
    }
}

// get the id of the animal that chosen and nevigate to details page
function DetailsClick() {
    let animalId = this.value;
    window.location.href = `/Home/AnimalDetails/${animalId}`;
}


function chosenCategory() {
    const select = document.querySelector(".formCategory");
    select.submit();
    //let selectValue = document.querySelector(".categorySelect").value;
    //window.location.href = `/Home/CatalogPage/${selectValue}`;
}

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

//funcs for the Admin page

function chosenCategoryForAdmin() {
    const select = document.querySelector(".formCategory");
    select.submit();
    //let selectValue = document.querySelector(".categorySelect").value;
    //window.location.href = `/Home/AdministratorPage/${selectValue}`;
}

// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

//funcs for the Add animal page

function fileValidation() {
    let inputFile = document.querySelector(".animal-file").value;
    let errorMessege = document.querySelector(".file_validation");
    if (inputFile == "") {
        errorMessege.innerHTML = "Input image";  
    }
}

function removeValidation() {
    let inputFile = document.querySelector(".animal-file").value;
    let errorMessege = document.querySelector(".file_validation");
    if (inputFile != null)
        errorMessege.innerText = "";
}