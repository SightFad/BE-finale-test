const tabs = document.querySelectorAll('.tab_btn')
const all_content = document.querySelectorAll('.content')

tabs.forEach((tab, index) => {
    tab.addEventListener('click', () => {
        tab.forEach(tab => {tab.classList.remove('active') })
        tab.classList.add('active');
    })
})