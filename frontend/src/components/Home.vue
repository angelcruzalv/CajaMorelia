<template>
    <div>
        <h1 class="display-4 text-center">Clientes</h1>
        {{clientList}}
        <div class="container mt-3">
  <div class="container mt-3">           
  <table class="table table-dark table-striped">
    <thead>
      <tr>
        <th>ID</th>
        <th>Nombre</th>
        <th>Apellido paterno</th>
        <th>Apellido materno</th>
        <th>RFC</th>
        <th>CURP</th>
        <th>Fecha de alta</th>
        <th>Accciones</th>

      </tr>
    </thead>
    <tbody>
      <tr v-for="(client, index) of clientList" :key = "index">
        <td>{{client.id_cliente}}</td>
        <td>{{client.nombre}}</td>
        <td>{{client.apellido_paterno}}</td>
        <td>{{client.apellido_materno}}</td>
        <td>{{client.rfc}}</td>
        <td>{{client.curp}}</td>
        <td>{{client.fecha_alta}}</td>
        <td>  <i class="fa-solid fa-trash"></i> </td>
      </tr>
      
    </tbody>
  </table>
  </div>
</div>
    </div>
</template>

<script>
    import axios from "axios";
    export default {
        name : 'HomeComponent',
        data(){
            return{
                client: '',
                clientList: []
            }
        },
        methods: {
            getData(){
                axios.get("https://localhost:44364/api/Clientes").then(response => {
                    console.log(response)
                    this.clientList=response.data
                })
            }
        },
        created: function(){
            this.getData();
        }
    }
</script>

<style scoped>

</style>