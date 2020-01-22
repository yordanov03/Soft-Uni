function solve(){
	let title = document.getElementById("createTitle").value;
	let content = document.getElementById("createContent").value;

	if (title && content) {
		let titleElement = document.createElement('h3');
		titleElement.textContent = title;

		let contentElement = document.createElement('p');
		contentElement.textContent = content;

		let articleElement = document.createElement('article');
		articleElement.appendChild(titleElement);
		articleElement.appendChild(contentElement);

		let articlesElement = document.getElementById('articles');
		articlesElement.appendChild(articleElement);

		titleElement.value = "";
		contentElement.value = "";
	}
}