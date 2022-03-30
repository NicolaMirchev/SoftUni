import * as api from './api.js';



export async function getAllMemes(){
    return api.get('/data/memes?sortBy=_createdOn%20desc');
}