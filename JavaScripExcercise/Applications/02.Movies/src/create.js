import {showView} from './dom.js';

const loginSection = document.getElementById('add-movie');

export function showCreateMovie(){
    showView(loginSection);
}