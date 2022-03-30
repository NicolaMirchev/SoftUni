import * as api from './api/api.js';
import {page, render} from './lib.js';
import {homePage} from './views/home.js';
import { catalogPage } from './views/catalog.js';
import { loginPage } from './views/login.js';
import { registerPage} from './views/register.js';
import {detailsPage} from './views/details.js';
import { editPage } from './views/edit.js';
import { createPage } from './views/create.js';

const root = document.querySelector('main');

page(decorateContext);
page('/', homePage);
page('/memes', catalogPage);
page('/login', loginPage);
page('/register', registerPage);
page('/details/:id', detailsPage);
page('/edit/:id', editPage);
page('/create', createPage);

window.decorate = homePage;

page.start();

function decorateContext(ctx, next){
    ctx.render = (content) => render (content, root); 

    next();
}