import {showHome, loadMovies} from './home.js';
import {showRegister} from './register.js';
import {showLogin} from './login.js';
import {} from './edit.js';

showHome();
loadMovies();

const navBar = document.querySelector('nav');

navBar.addEventListener('click', showRequiredView)
function showRequiredView(event){
    
    const differentViews = {homeLink : showHome,
                            logoutBtn : showHome,
                            loginLink : showLogin,
                            registerBtn : showRegister};
                         
                            

    if (typeof differentViews[event.target.id] == 'function'){

        if(event.target.id== 'logoutBtn'){
            sessionStorage.clear();          
        }
     
       
        differentViews[event.target.id]();
    }
    else if (event.target.id == 'homeLink') showHome();                           

}