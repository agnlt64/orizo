const hamburger = document.querySelector('.hamburger-btn');
const sidenav = document.getElementById('sidenav');
const overlay = document.querySelector('.overlay');
// const overlay = document.createElement('div');
// overlay.classList.add('overlay');
// document.body.appendChild(overlay);

hamburger.addEventListener('click', () => {
    document.body.classList.toggle('no-scroll');

    const currentState = hamburger.getAttribute("data-state");

    if (!currentState || currentState === "closed") {
        hamburger.setAttribute("data-state", "opened");
        hamburger.setAttribute("aria-expanded", "true");
        sidenav.classList.add('show');
        overlay.classList.add('show');
        sidenav.animate([
            { transform: 'translateX(100%)' },
            { transform: 'translateX(0)' }
        ], {
            duration: 500,
            easing: 'ease-in-out'
        });
    } else {
        hamburger.setAttribute("data-state", "closed");
        hamburger.setAttribute("aria-expanded", "false");
        const animation = sidenav.animate([
            { transform: 'translateX(0)' },
            { transform: 'translateX(100%)' }
        ], {
            duration: 500,
            easing: 'ease-in-out',
        });
        overlay.classList.remove('show');
        animation.addEventListener('finish', () => {
            sidenav.classList.remove('show');
        });
    }
});