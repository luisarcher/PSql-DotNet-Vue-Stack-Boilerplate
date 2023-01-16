<template>
    <div>
        <h2>Users</h2>
        <div class="grid grid-cols-4 gap-5">
            <div v-for="u in users">
                <p>{{ u.firstName }}</p>
            </div>
        </div>
    </div>
</template>

<script setup>
    const apiUrl = `http://localhost:5001/users`;
    const { data : users } = await useFetch(apiUrl);

</script>

<style scoped>
    h2 {
        margin-bottom: 20px;
        font-size: 36px;
    }

    p {
        margin: 20px 0;
    }
</style>