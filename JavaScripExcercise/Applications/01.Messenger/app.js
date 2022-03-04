function attachEvents() {


    document.getElementById('refresh').addEventListener('click', loadMessages);
    document.getElementById('submit').addEventListener('click', createNewMember);


    loadMessages();
}

attachEvents();

async function loadMessages(){
    const url = 'http://localhost:3030/jsonstore/messenger';
    const resp = await fetch(url);
    const values =  Object.values(await resp.json());


    const content = values.map(v => `${v.author}: ${v.content}`);
    document.getElementById('messages').value = content.join('\n'); 
}

async function createNewMember(){

    const url = 'http://localhost:3030/jsonstore/messenger';

    const name = document.querySelector('[name="author"]');
    const content = document.querySelector('[name="content"]');

    const body = {author : name.value,
                content: content.value};

    const resp = await fetch(url, {
            method: 'post',
            headers: {'Content-type' : 'application/json'},
            body: JSON.stringify(body)});
            
            document.getElementById('messages').value += `\n${body.author}: ${body.content}`;

            name.value ='';
            content.value = '';
} 
