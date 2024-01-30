class Deque {
    constructor() {
        this.items = [];
    }

    isEmpty() {
        return this.items.length === 0;
    }

    addFirst(element) {
        this.items.unshift(element);
    }

    addLast(element) {
        this.items.push(element);
    }
}