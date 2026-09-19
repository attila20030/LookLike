<template>
    <Html lang="hu">
      <Text>Kedves {{ name }},</Text>
      <Text>Köszönjük, hogy regisztráltál! Kérjük, erősítsd meg e-mail címedet az alábbi kóddal:</Text>
      <Text><strong>{{ verificationCode }}</strong></Text>
      <Text>Üdvözlettel,<br/>A Csapat</Text>
    </Html>
  </template>
  
  <script setup>
  import { Html, Text } from '@vue-email/components';
  
  defineProps({
    name: String,
    verificationCode: String,
  });
  </script>
  