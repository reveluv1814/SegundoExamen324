<h3>Proceso 3 </h3>
<h4>Presentar Inscripción</h4>
<input type="hidden" name="id" value=""/>
<span>
    <input type="file" name="presentar" id="presentar" value=""/>
</span>
<label for="presentar">
    <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6" fill="none" viewBox="0 0 24 24" stroke="currentColor" stroke-width="2">
    <path stroke-linecap="round" stroke-linejoin="round" d="M4 16v1a3 3 0 003 3h10a3 3 0 003-3v-1m-4-8l-4-4m0 0L8 8m4-4v12" />
    </svg>
    <span>Selecciona Tu Documento</span>
</label>




<!-- estilo-->
<style>
    h3{
        font-size: 30px;
        font-weight: 400;
        text-align: center;
        color: #3A4750;
    }
    h4{
        font-size: 35px;
        font-weight: bold;
        text-align: center;
        color: #3A4750;
    }
    #presentar{
        width: 0.1px;
        height: 0.1px;
        opacity: 0;
        overflow: hidden;
        position: absolute;
        z-index: -1;
    }
    svg{
        
        width: 30px;
    }
    label{
        font-size: 14px;
        font-weight: 600;
        color: #fff;
        background-color: #106BA0;
        display: inline-block;
        transition: all .5s;
        cursor: pointer;
        padding: 15px 40px !important;
        text-transform: uppercase;
        width: fit-content;
        text-align: center;
        margin-left: 25%;
        margin-bottom: 20px;
        margin-top: 20px;
        border-radius: 20px;
        box-shadow: 0 6px 20px -5px rgba(0,0,0,0.4);
    }
</style>