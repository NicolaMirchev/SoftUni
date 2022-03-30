
import {html} from '../lib.js';
import { editMemeById, getMemeById, getUserData, updateNav } from '../util.js';



const editTemplate =  (meme, onSubmit) => html`   
        <section id="edit-meme">
            <form @submit=${onSubmit} id="edit-form">
                <h1>Edit Meme</h1>
                <div class="container">
                    <label for="title">Title</label>
                    <input id="title" type="text" placeholder="${meme.title}" value="${meme.title}" name="title">
                    <label for="description">Description</label>
                    <textarea id="description" placeholder="${meme.description}" name="description" value="${meme.description}">
                           
                        </textarea>
                    <label for="imageUrl">Image Url</label>
                    <input id="imageUrl" type="text" placeholder="${meme.imageUrl}" value="${meme.imageUrl}" name="imageUrl">
                    <input type="submit" class="registerbtn button" value="Edit Meme">
                </div>
            </form>
        </section>
`
export async function editPage(ctx) {

    const id = ctx.params['id'];
    const meme = await getMemeById(id);


    ctx.render(editTemplate(meme, onSubmit));
    updateNav();

    async function onSubmit(event){
        event.preventDefault();

        const formData = new FormData(event.target);
        const title = formData.get('title');
        const description = formData.get('description');
        const imgUrl = formData.get('imageUrl');

        if(title == '' || description == '' || imgUrl == ''){
            throw new Error('All fields are requierd!!!');
        }
        else {

            const data = {title, description, imgUrl};
            await editMemeById(id, data);

            ctx.page.redirect('/details/' + id);
        }

    }
    
}