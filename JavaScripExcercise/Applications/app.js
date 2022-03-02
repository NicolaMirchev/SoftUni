function loadRepos() {

	const name = document.querySelector('button');


	
	name.addEventListener('click', loadRequest);


	async function loadRequest(event){
		const url = `https://api.github.com/users/${document.getElementById('username').value}/repos`;

		try {			
			const response = await fetch(url);

			if(!response.ok) throw new Error(`${response.status} ${response.statusText}`)

			 response.json().then(displayRepos);
			
			function displayRepos(data){
				const list = document.getElementById('repos');

				for (const repo of data) {

					const currentElement = document.createElement('li');
					currentElement.innerHTML = `<a href="${repo.html_url}"> ${repo.full_name} </a>`;

					list.appendChild(currentElement);
				}

			}

		} catch (error) {
			console.log(error)
		}

		document.getElementById('repos').innerHTML = '';

	}


}