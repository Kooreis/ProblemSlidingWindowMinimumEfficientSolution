removeFirst() {
        if (this.isEmpty()) {
            return null;
        }
        return this.items.shift();
    }

    removeLast() {
        if (this.isEmpty()) {
            return null;
        }
        return this.items.pop();
    }