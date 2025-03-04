// windowInterop.js
export function registerMouseMove(callback) {
    const handler = (e) => callback(e.clientX, e.clientY);
    document.addEventListener('mousemove', handler);
    return handler;
}

export function registerMouseUp(callback) {
    const handler = () => callback();
    document.addEventListener('mouseup', handler);
    return handler;
}

export function unregisterEvents(handler) {
    document.removeEventListener('mousemove', handler);
    document.removeEventListener('mouseup', handler);
}